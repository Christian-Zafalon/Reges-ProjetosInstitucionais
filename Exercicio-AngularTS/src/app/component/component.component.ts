import { Component, OnInit } from '@angular/core';
import { Cliente } from '../models/Cliente';

@Component({
  selector: 'app-component',
  templateUrl: './component.component.html',
  styleUrls: ['./component.component.css']
})
export class ComponentComponent implements OnInit {

  public model = new Cliente();

  constructor() { }

  ngOnInit(): void {
  }

  enviarCliente(){
    console.log(this.model)
  }

}
