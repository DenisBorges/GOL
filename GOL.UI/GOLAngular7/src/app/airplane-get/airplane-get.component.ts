import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AirplaneService } from '../services/airplane.service';
import Airplane from '../model/airplane';
import objectServerResponse from '../model/objectServerResponde';
import airplane from '../model/airplane';

@Component({
  selector: 'app-airplane-get',
  templateUrl: './airplane-get.component.html',
  styleUrls: ['./airplane-get.component.css']
})
export class AirplaneGetComponent implements OnInit {
 
 airplaneList: Airplane[];

  constructor(private ap: AirplaneService,
    private route: ActivatedRoute,
    private router: Router) { 
  }

  ngOnInit() {
    this.getListAiplane();
  }

  getListAiplane(){
    this.ap.getListAirplane().subscribe((res:objectServerResponse) => {
      debugger;
      console.log(res);
      this.airplaneList = res.data;
    });
  }

  editAirplane(id){
    
    var myurl = `/airplane/edit/${id}`;

    this.router.navigateByUrl(myurl);

  };

  deleteAirplane(id){
    //debugger;
    const res = confirm('Gostaria de Excluir esse registro ?');
    if (res) {
      this.ap.deleteAirplane(id).subscribe(()=>{
          alert('Excluído com sucesso');
      });
    }
    
  };

}
