import { Component, OnInit } from '@angular/core';
import { Task } from '../../../Task/task';
import { TaskService } from 'src/app/Task/task.service';
import { Router } from "@angular/router"; 
import { Select2OptionData } from 'ng-select2';
import { ProjectService } from 'src/app/Project/project.service';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {

  tasks: Task[]; 
  searchProjects: Array<Select2OptionData>;  
  
  constructor(private projectService: ProjectService, private taskService: TaskService, private router: Router, ) { }  
  
  ngOnInit() {
    localStorage.removeItem('editTaskID')   
    this.getTasks();
    this.getProjectDynamicList();  
  }

  getTasks()
  {
    this.taskService.getTasks()  
    .subscribe((data: Task[]) => {
      this.tasks = data;
      if(data.length == 0)  
      {
        alert("No items found");   
      }       
    });
  }

  getProjectDynamicList(){
    this.projectService.getProjectList()  
    .subscribe((data: Array<Select2OptionData>) => {
      this.searchProjects = data;      
      if(data.length == 0)  
      {
        alert("No user List found");         
      }         
    }); 
}

onProjectSelectTask(projectSelected){
  if (projectSelected != null)
  {
    this.taskService.getTasks()  
    .subscribe((data: Task[]) => {
      this.tasks = data;
      if(projectSelected.value != null)
      {
      this.tasks = this.tasks.filter(x=> x.projectID.toString() == projectSelected.value); 
      }
      else
      {
      this.tasks = this.tasks.filter(x=> x.projectID.toString() == projectSelected);
      }      
      if(data.length == 0)  
      {
        alert("No tasks found");         
      }         
    });            
  }
}

  editTask(task: Task): void {  
    localStorage.removeItem('editTaskID');  
    localStorage.setItem('editTaskID', task.taskID.toString());  
    this.router.navigate(['projectmanagertask']);  
  }

  endTask(task: Task) {  
    task.endDate = new Date(Date.now());    
    this.taskService.updateTask(task).subscribe((data: any) => {
      if(data)
      {  
        alert("Task end successfully");          
        location.reload();     
      }
      else
      {
        alert("End Task update failed due to server error, kindly try again");     
      }
    },  
    error => {  
      alert(error);  
    });
  }
}
