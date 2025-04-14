import { Component } from '@angular/core';
import { Category, CategoryService } from '../myservice.service';

@Component({
  selector: 'app-category',
  standalone: false,
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})
export class CategoryComponent {
categories: Category[] = [];
selectedCategory: Category | null = null;


  constructor(private categoryService: CategoryService  ) { }

  ngOnInit(): void {
    this.loadAllCategories();
  }

  loadAllCategories() {
    this.categoryService.getAll().subscribe((data) => {
      this.categories = data
    })
  }

  loadById(id: number) {
    this.categoryService.getById(id).subscribe(data => {
      this.selectedCategory = data;
    });
  }

  loadByName(name: string) {
    this.categoryService.getByName(name).subscribe(data => {
      this.selectedCategory = data;
    });
  }

  loadFirst() {
    this.categoryService.getFirst().subscribe(data => {
      this.selectedCategory = data;
    });
  }
}
