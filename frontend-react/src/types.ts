export interface Pessoa {
  id: number;
  nome: string;
  idade: number;
}
export interface Transacao {
  id: number;
  descricao: string;
  valor: number;
  tipo: "CREDITO" | "DEBITO";
  id_Pessoa: number;
}
export interface RelatorioPessoal {
  id?: number;
  Id?: number;
  ID?: number;
  [key: string]: any;
}
export interface RelatorioGeral {
  totalReceitas: number;
  totalDespesas: number;
  saldoGeral: number;
}
