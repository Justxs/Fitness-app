export default class FoodRecord {
    id = 0;
    name = '';
    calories = 0;
    proteins = 0.0;
    carbohydrates = 0.0;
    fats = 0.0;
    imageUrl = '';
    user = null;
    date = null;
    

    constructor(id,name,calories,proteins,carbohydrates,fats,imageUrl,user,date){
        this.id = id;
        this.name = name;
        this.calories = calories;
        this.proteins = proteins;
        this.carbohydrates = carbohydrates;
        this.fats = fats;
        this.imageUrl = imageUrl;
        this.user = user;
        this.date = date;
    }
}