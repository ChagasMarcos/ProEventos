import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {

  public eventos: any = [];
  public eventosFiltrados: any = [];
  widthImg: number = 80;
  marginImg: number = 2;

  imgToggleBtn : boolean = true;
  toggleBtnIcon = "fa-solid fa-eye-slash";
  private _filtroLista: string = '';

public get filtroLista(): string {
return this._filtroLista;
};

public set filtroLista(value:string) {
this._filtroLista = value;
this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
}

filtrarEventos(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      evento.local.toLowerCase().indexOf(filtrarPor) !== -1
    )
}

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getEventos();
  }

  public toglleBtnImg() {
    this.imgToggleBtn = !this.imgToggleBtn;
    if (this.imgToggleBtn == true ) {
      this.toggleBtnIcon = "fa-solid fa-eye-slash"
    } else {
      this.toggleBtnIcon = "fa-solid fa-eye"
    }
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => {
        this.eventos = response,
        this.eventosFiltrados = this.eventos
      },
      error => console.log(error),
    );
  }

}
