
import { Lote } from "./Lote";
import { Palestrante } from "./Palestrante";
import { RedeSocial } from "./RedeSocial";

export interface Evento {
 id : number | undefined;
 local : string | undefined ;
 dataEvento? : Date | undefined ;
 tema : string | undefined ;
 qtdPessoas : number | undefined ;
 lote : string | undefined ;
 imagemURL : string | undefined;
 telefone: string | undefined;
 email : string | undefined;
 lotes: Lote[];
 redesSociais: RedeSocial[];
 palestrantesEventos: Palestrante[];
}
