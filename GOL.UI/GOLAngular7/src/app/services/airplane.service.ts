import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AirplaneService {

  uri = 'https://localhost:5001/api/values';

  constructor(private http: HttpClient) { }

  //ADD(POST DATA)
  addAirplane(codigo, modelo, qtd_passageiros) {
    const registro = {
      codigo_do_aviao: codigo,
      modelo,
      qtd_passageiros
    };
    //console.log(registro);

    //GET
   //this.http.get(`${this.uri}/values`).subscribe((res)=>{7
      //debugger;
      //console.log(res);
    //});

    //POST
    return this.http.post(`${this.uri}/Inserir`, registro);
  }

  // DELETE
  deleteAirplane(id){
    debugger;
    return this.http.delete(`${this.uri}/Apagar/${id}`);
  }
  
  //GET ITEM BY ID
  getItembyId(id){
    return this.http.get(`${this.uri}/Get/${id}`);
  }

  //LIST(GET DATA)
  getListAirplane(){
    return this.http.get(`${this.uri}/ListarTodos`);
  }

  //ATUALIZAR
  updateAirplane(id,codigo_do_aviao, modelo, qtd_passageiros,dt_criacao_registro){

    debugger;
    const registro = {
      id,
      codigo_do_aviao,
      modelo,
      qtd_passageiros,
      dt_criacao_registro
    };

    return this.http.post(`${this.uri}/Atualizar`,registro);
  }

}
