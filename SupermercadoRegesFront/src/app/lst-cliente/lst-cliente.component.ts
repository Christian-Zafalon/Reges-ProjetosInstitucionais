import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-lst-cliente',
  templateUrl: './lst-cliente.component.html',
  styleUrls: ['./lst-cliente.component.css']
})
export class LstClienteComponent implements OnInit {

  constructor(private route: Router) { }

  Cliente = [
    {
      id: 1,
      nome: 'Christian',
      telefone: '16 991075965',
      email: "chris.alenda.2013@gmail.com",
      documento: "52601548560",
      dataNascimento: "25/05/2005",
      uf: "SP",
      cidade: "Ribeirao preto",
      bairro: "Fiusa",
      rua: "Micoto Miazaka",
      numero:"92",
      cep:"1405225602",
      logradouro:"palace",
      complemento:"Predio"
    },

    {
      id: 2,
      nome: 'Caio',
      telefone: '16 991075965',
      email: "teste.alenda.2013@gmail.com",
      documento: "52655548560",
      dataNascimento: "27/07/2007",
      uf: "BH",
      cidade: "UberLandia",
      bairro: "Centro",
      rua: "Micoto Miazaka",
      numero:"92",
      cep:"1405225602",
      logradouro:"palace",
      complemento:"Casa"
    },
    {
    id: 3,
    nome: 'Leandro',
    telefone: '16 995246254',
    email: "leandro.alenda.2013@gmail.com",
    documento: "52601548560",
    dataNascimento: "25/05/2005",
    uf: "MG",
    cidade: "Paio preto",
    bairro: "City",
    rua: "Micoto Mussaza",
    numero:"52",
    cep:"1405225453",
    logradouro:"palace",
    complemento:"Apartamento"
    }
  ]


  cadastrarCliente(){
    this.route.navigate(["/cliente"]);
  }

  ngOnInit(): void {
  }

}
