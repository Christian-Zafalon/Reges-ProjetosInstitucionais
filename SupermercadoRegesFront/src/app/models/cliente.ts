import { Pessoa } from "./pessoa";
import { Endereco } from "./endereco";
export class Cliente {
    numeroCartaoFidelidade!: string;
    pessoa: Pessoa = new Pessoa;
    endereco: Endereco = new Endereco;
}