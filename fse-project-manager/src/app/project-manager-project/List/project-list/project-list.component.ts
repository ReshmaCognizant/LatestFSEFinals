import { Component, OnInit } from '@angular/core';
import { ProjectService } from 'src/app/Project/project.service';
import { Router } from "@angular/router"; 
import { Project } from '../../../Project/project';

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.css']
})
export class ProjectListComponent implements OnInit {

  purchaseOrders: any;  
  
  constructor(private projectService: ProjectService, private router: Router, ) { }  
  
  ngOnInit() { 
      localStorage.removeItem('editProjectID')    
      this.getProjects();    
  } 

  getProjects()
  {
      this.projectService.getProjects()  
      .subscribe((data: Project[]) => {
        this.purchaseOrders = data;  
        if(data.length == 0)  
        {
          alert("No projects found");          
        }         
      });
  }

  deleteProject(project: Project): void {  
    this.projectService.deleteProject(project.projectID)  
    .subscribe((data: any) => {
      if(data)
      {  
        alert("Project deleted successfully");        
        this.getProjects();  
      }
      else
      {
        alert("Project deletion failed due to server error, kindly try again");     
      }
    },  
    error => {  
      alert(error);  
    });  
  }  
  
  editProject(project: Project): void {  
    localStorage.removeItem('editProjectID');  
    localStorage.setItem('editProjectID', project.projectID.toString());  
    this.router.navigate(['projectmanagerproject']);  
  }
}
