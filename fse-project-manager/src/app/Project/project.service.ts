import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Project } from './project';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { AppHttpService } from 'src/app/app-http.service';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  constructor(private http: HttpClient, private appHttpService : AppHttpService) { }  
  baseUrl: string = 'http://localhost:61012/api/project/';  
  
  getProjects(): Observable<Project[]> {
    return this.http.get<Project[]>(this.baseUrl + 'get')
      .pipe(
        tap(_ => this.appHttpService.log('fetched projects')),
        catchError(this.appHttpService.handleError)
      );
  }
  
  deleteProject(projectID: number) {  
    return this.http.delete(this.baseUrl + 'delete/' + projectID)
    .pipe(
      tap(_ => this.appHttpService.log('deleted Project')),
      catchError(this.appHttpService.handleError)
    );
  }  

  createProject(project: Project) {  
    return this.http.post(this.baseUrl + 'add', project)
    .pipe(
      tap(_ => this.appHttpService.log('created Project')),
      catchError(this.appHttpService.handleError)
    );
  }

  searchProject(purchaseOrderNo: string, itemCode: string) {  
    return this.http.get<Project>(this.baseUrl + 'search/' + purchaseOrderNo + '/' + itemCode)
    .pipe(
      tap(_ => this.appHttpService.log('searched Project')),
      catchError(this.appHttpService.handleError)
    );  
  }

  updateProject(project: Project) {  
    return this.http.put(this.baseUrl + 'update', project)
    .pipe(
      tap(_ => this.appHttpService.log('updated Project')),
      catchError(this.appHttpService.handleError)
    ); 
  }
}