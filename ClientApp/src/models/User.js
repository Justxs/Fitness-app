export default class User {
    id = 0;
    firstName = '';
    lastName = '';
    username = '';
    email = '';
    

    constructor(id,firstName,lastName,username,email){
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.username = username;
        this.email = email;
    }
}