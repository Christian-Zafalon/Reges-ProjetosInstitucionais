import { Endereco } from "./endereco";

// ng g class models/pessoa --skip--tests
export class Pessoa {
    id!: number;
    nome!:string;
    telefone!:string;
    email!:string;
    documento!:string;
    dataNascimento!: Date;
    endereco: Endereco = new Endereco;
}
