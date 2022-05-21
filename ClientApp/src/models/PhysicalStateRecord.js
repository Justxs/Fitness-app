export default class PhysicalStateRecord {
    date = new Date();
    weight = 0;
    height = 0;
    user = null;
    userId = 0;

    constructor(date,weight,user,userId) {
        this.date = date;
        this.weight = weight;
        this.user = user
        this.userId = userId;
    }
}