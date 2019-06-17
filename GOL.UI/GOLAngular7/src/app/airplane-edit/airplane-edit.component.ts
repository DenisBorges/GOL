import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AirplaneService } from '../services/airplane.service';
import Airplane from '../model/airplane';
import objectServerResponde from '../model/objectServerResponde';

@Component({
  selector: 'app-airplane-edit',
  templateUrl: './airplane-edit.component.html',
  styleUrls: ['./airplane-edit.component.css']
})

export class AirplaneEditComponent implements OnInit {

  airplane: any = {};
  angForm: FormGroup;

  constructor(private route: ActivatedRoute,
    private router: Router,
    private ap: AirplaneService,
    private fb: FormBuilder) {

    this.createForm();
  }

  createForm() {
    this.angForm = this.fb.group({
      id: [{value: ''}, Validators.required],
      codigo_do_aviao: [0, Validators.required],
      modelo: ['', Validators.required],
      qtd_passageiros: ['', Validators.required],
      dt_criacao_registro: [{value: '', disabled: true}, Validators.required]
    });
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.ap.getItembyId(params['id']).subscribe((res: objectServerResponde) => {
        //debugger;
        this.airplane = res.data;
      });
    });
  }

  updateAirplane(id, codigo, modelo, qtd_passageiros, dt_criacao_registro) {
    this.ap.updateAirplane(id, codigo, modelo, qtd_passageiros, dt_criacao_registro)
      .subscribe(res => {
        alert("Atualizado com Sucesso");
        this.router.navigateByUrl('/airplane');
      }
      );
  }

}
