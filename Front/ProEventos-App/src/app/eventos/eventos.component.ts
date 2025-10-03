import { Component, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';

import { EventoService } from './../services/evento.service';
import { Evento } from '../models/Evento';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
  //providers: [EventoService]
})
export class EventosComponent {

  public modalRef?: BsModalRef;
  public eventos: Evento[] = [];
  public eventosFiltrados: Evento[] = [];
  public widthImg: number = 80;
  public marginImg: number = 2;

  public imgToggleBtn : boolean = true;
  public toggleBtnIcon = "fa-solid fa-eye-slash";
  private _filtroLista: string = '';

  public get filtroLista(): string {
  return this._filtroLista;
  };

  public set filtroLista(value:string) {
  this._filtroLista = value;
  this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
  }

  public filtrarEventos(filtrarPor: string): Evento[] {
      filtrarPor = filtrarPor.toLocaleLowerCase();
      return this.eventos.filter(
        (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
        evento.local.toLowerCase().indexOf(filtrarPor) !== -1
      )
  }

  constructor(private eventoService: EventoService,
              private modalService: BsModalService,
              private toastr: ToastrService,
              private spinner: NgxSpinnerService) {}

  public ngOnInit(): void {
    this.spinner.show();
    this.getEventos();
    }

  public toglleBtnImg() : void {
    this.imgToggleBtn = !this.imgToggleBtn;
    if (this.imgToggleBtn == true ) {
      this.toggleBtnIcon = "fa-solid fa-eye-slash"
    } else {
      this.toggleBtnIcon = "fa-solid fa-eye"
    }
  }

  public getEventos(): void {
    this.eventoService.getEventos().subscribe({
      next: (_eventos: Evento[]) => {
      this.eventos = _eventos,
        this.eventosFiltrados = this.eventos
      },
      error: (error: any) => {
        this.spinner.hide();
        this.toastr.error('Erro ao carregar Eventos.', 'Erro');
      },
      complete: () => this.spinner.hide()
    });
  }


  openModal(template: TemplateRef<any>) : void {
    this.modalRef = this.modalService.show(template, { class: 'modal-sm' });
  }

  confirm(): void {
    this.modalRef?.hide();
    this.toastr.success('Evento deletado com sucesso.', 'Deletado');
  }

  decline(): void {
    this.modalRef?.hide();
  }

}
