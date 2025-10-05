import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-titulo',
  templateUrl: './titulo.component.html',
  styleUrls: ['./titulo.component.scss']
})
export class TituloComponent implements OnInit {

  @Input() titulo?: string;
  @Input() subtitulo = 'Desde 2025';
  @Input() iconPage = 'fa fa-user';
  @Input() botaoListar?: boolean;

  constructor() { }

  ngOnInit() {
  }

}
