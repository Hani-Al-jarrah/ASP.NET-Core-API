import { Component } from '@angular/core';
import { HaniService } from '../Service/hani.service';

export interface Category {
  categoryId: number;
  categoryName: string;
  categoryDescription: string;
}

@Component({
  selector: 'app-category',
  standalone: false,
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})
export class CategoryComponent {

  categoryList: Category[] = [];
  isEditMode: boolean = false;

  newCategory: Category = {
    categoryId: 0,
    categoryName: '',
    categoryDescription: ''
  };

  constructor(private _ser: HaniService) { }

  ngOnInit() {
    this.getAllCategories();
  }

  getAllCategories() {
    this._ser.getCategories().subscribe( (data: any) => {
        alert("Fetched categories:");
        this.categoryList = data;
      }
     
    );
  }

  addCategory(formData: any) {
    const fromform = new FormData();
    fromform.append("categoryName", formData.categoryName);
    fromform.append("categoryDescription", formData.categoryDescription);

    this._ser.AddCategories(fromform).subscribe(() => {
        alert('Category added successfully');
        this.getAllCategories();
        this.resetForm();
      }
      
    );
  }

  editCategory(cat: Category) {
    this.newCategory = { ...cat };// to accept any type of data
    this.isEditMode = true;
  }

  updateCategory() {
    this._ser.updateCategory(this.newCategory.categoryId, this.newCategory).subscribe( ()=> {
        alert('Category updated successfully');
        this.getAllCategories();
        this.resetForm();
      }
      
    );
  }

  resetForm() {
    this.newCategory = {
      categoryId: 0,
      categoryName: '',
      categoryDescription: ''
    };
    this.isEditMode = false;
  }

  deleteCategory(id: any) {
    if (confirm('Are you sure you want to delete this category?')) {
      this._ser.deleteCategory(id).subscribe( () => {
          this.getAllCategories(); // Refresh list after deletion
        }
        
      );
    }
  }

}
