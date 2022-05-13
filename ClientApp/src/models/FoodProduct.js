export default class FoodProduct {
    id = 0;
    name = '';
    calories100g = 0;
    proteins100g = 0.0;
    carbohydrates100g = 0.0;
    fats100g = 0.0;
    imageUrl = '';

    constructor(id,name,calories100g,proteins100g,carbohydrates100g,fats100g,imageUrl){
        this.id = id;
        this.name = name;
        this.calories100g = calories100g;
        this.proteins100g = proteins100g;
        this.carbohydrates100g = carbohydrates100g;
        this.fats100g = fats100g;
        this.imageUrl = imageUrl;
    }
}