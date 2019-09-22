import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from "@angular/router";  
import { ProjectService } from 'src/app/Project/project.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-project-manager-project',
  templateUrl: './project-manager-project.component.html',
  styleUrls: ['./project-manager-project.component.css'],
  providers:[DatePipe]
})
export class ProjectManagerProjectComponent implements OnInit {

  purchaseOrderformlabel: string = 'Add Item';  
  constructor(private formBuilder: FormBuilder, private router: Router, private projectService: ProjectService, private datePipe: DatePipe) {  
  }  
  
  addForm: FormGroup;
  btnvisibility: boolean = true;  
  ngOnInit() {  
  
    this.addForm = this.formBuilder.group({      
      purchaseOrderNo: ['', [Validators.required, Validators.maxLength(4)]],
      purchaseDate: [],  
      supplierNo: ['', [Validators.required, Validators.maxLength(4)]], 
      itemCode: ['', [Validators.required, Validators.maxLength(4)]],
      quantity: []  
    });  
  
    let projectID = localStorage.getItem('editProjectID');
    if (projectID != undefined && projectID != '') {      
      this.projectService.searchProject(projectID).subscribe(data => {  
        this.addForm.patchValue(data);        
      })  
      this.btnvisibility = false;
      this.purchaseOrderformlabel = 'Edit Project';      
    } 
  }

  onSubmit() {
    this.projectService.createProject(this.addForm.value)  
      .subscribe((data: any) => {
        if(data)
        {  
          alert("Project added successfully");        
          this.router.navigate(['project-list']); 
        }
        else
        {
          alert("Project add failed due to server error, kindly check whether Supplier No and Item Code exists and try again");     
        }
      },  
      error => {  
        alert(error);  
      });  
  }  
  onUpdate() {      
    this.projectService.updateProject(this.addForm.value).subscribe((data: any) => {
      if(data)
      {  
        alert("Project updated successfully");        
        localStorage.removeItem('editProjectID') 
        this.router.navigate(['project-list']);  
      }
      else
      {
        alert("Project update failed due to server error, kindly try again");     
      }
    },  
    error => {  
      alert(error);  
    });
  }
}
