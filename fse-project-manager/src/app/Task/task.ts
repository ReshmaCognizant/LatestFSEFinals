export class Task {
  taskID: number;
    parentID: number;
    projectID: number;
    taskName: string;
    parentTaskName: string;
    startDate: Date;
    endDate: Date;
    priority: number;
    status: string;
  }