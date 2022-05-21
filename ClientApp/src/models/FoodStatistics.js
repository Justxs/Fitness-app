export default class FoodRecord {
    calories = 0.0;
    proteins = 0.0;
    carbohydrates = 0.0;
    fats = 0.0;
    user = null;
    

    constructor(calories,proteins,carbohydrates,fats,user){
        this.calories = calories;
        this.proteins = proteins;
        this.carbohydrates = carbohydrates;
        this.fats = fats;
        this.user = user;
    }
}