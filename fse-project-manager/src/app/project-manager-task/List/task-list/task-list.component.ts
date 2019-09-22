import { Component, OnInit } from '@angular/core';
import { Task } from '../../../Task/task';
import { TaskService } from 'src/app/Task/task.service';
import { Router } from "@angular/router"; 

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {

  taks: Task[];  
  
  constructor(private taskService: TaskService, private router: Router, ) { }  
  
  ngOnInit() {
    localStorage.removeItem('editTaskID')   
    this.getTaks();
  }

  getTaks()
  {
    this.taskService.getTasks()  
    .subscribe((data: Task[]) => {
      this.taks = data;
      if(data.length == 0)  
      {
        alert("No items found");   
      }       
    });
  }

  editTask(task: Task): void {  
    localStorage.removeItem('editTaskID');  
    localStorage.setItem('editTaskID', task.taskID.toString());  
    this.router.navigate(['projectmanagertask']);  
  }
}
