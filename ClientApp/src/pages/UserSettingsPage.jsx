import '../custom.scss';
import React, { useEffect, useState } from "react";
import { Button } from 'react-bootstrap';
import useCollapse from 'react-collapsed';
import '../settings.css';
import { Form, FormGroup, FormControl, ControlLabel } from "react-bootstrap";


function UserSettingsPage() {

const options=[
  {
  header: {
    name: "Account",
  },

  values:[
    {
      name: "Email",
      descritpion: "Change your email information",
      labeltext: "New email",
      Btntext: "Change",
      tags:[],

    },

    {
      name: "Password",
      descritpion: "Change your password",
      labeltext: "New Password",
      Btntext: "Change",
      tags:[],

    },

  ],
  },


  {
  header: {
    name: "Body Data",
  },

  values:[
    {
      name: "Weight",
      descritpion: "Input your weight information",
      labeltext: "Weight",
      Btntext: "Set",
      tags:[],

    },

    {
      name: "Height",
      descritpion: "Input your height information",
      labeltext: "Height",
      Btntext: "Set",
      tags:[],

    },

    {
      name: "Daily Calorie Intake Goal",
      descritpion: "Input your daily calorie intake goal",
      labeltext: "Goal",
      Btntext: "Set",
      tags:[],

    },

    {
      name: "Weight Goal",
      descritpion: "Input your weight goal information",
      labeltext: "Goal",
      Btntext: "Set",
      tags:[],

    },

  ],
  },

  {
    header: {
      name: "Notificatons",
    },
  
    values:[
      {
        name: "Email",
        descritpion: "Change your email information",
        labeltext: "New email",
        Btntext: "Change",
        tags:[],
  
      },
  
      
  
    ],
    },

];

///////////
//CONSTANTS
//////////
const [visibleOptions, setVisibleOptions] = useState(options);
const [ isExpanded, setExpanded ] = useState(false);
const { getCollapseProps, getToggleProps } = useCollapse({ isExpanded });
const [passwordShown, setPasswordShown] = useState(false);
const togglePassword = () => {
  // When the handler is invoked
  // inverse the boolean state of passwordShown
  setPasswordShown(!passwordShown);
};
function handleOnClick() {
    // Do more stuff with the click event!
    // Or, set isExpanded conditionally 
    setExpanded(!isExpanded);
}



  return (
    <div className="UserSettingsPage">
      <h1>Setings</h1>
      

    <div>
    




   

    

   


       
     

    


   








































    </div>
   

      <div class="mx-3 div-2"> 
        <h2 className="mx=2">General </h2>
        <div className="mb=5 background-custom"  >
        <label className="mx-2 "> 
                    <input type="checkbox"/> Use dark theme
                </label>
                <br></br><br></br>
                    
          



        </div>



        <h2 className="mx=2">Account</h2>

          <div className=" background-custom">
            <div className="mx-2">
          <h6 className="mb=2">Change Email Address</h6>
                          <Form>
                  <Form.Group className="mb-3" controlId="formBasicEmail">
                    <Form.Label>New Email address</Form.Label>
                    <Form.Control type="email" placeholder="Enter email" />
                    
                  </Form.Group>

                 
                  <Button variant="primary" type="submit">
                    Change
                  </Button>
                  <br></br><br></br>

                <h6 className="mb=2">Change Password</h6>

                <Form.Group className="mb-3" controlId="formBasicPassword">
                    <Form.Label>Password</Form.Label>
                    <Form.Control type="password" placeholder="Password" />
                  </Form.Group>
                  

                  <Form.Group className="mb-3" controlId="formBasicEmail">
                    <Form.Label>Confirm Password</Form.Label>
                    <Form.Control type="password" placeholder="Password" />
                    
                  </Form.Group>

                  <Button variant="primary" type="submit">
                    Change
                  </Button>
                  <br></br><br></br>

                </Form>

          </div>
          </div>

          <h2 className="mx=2">Body data</h2>
          <div className=" background-custom">
            <div className="mx-2">
          <h6 className="mb=2">Update your weight</h6>
                          <Form>
                  <Form.Group className="mb-3" controlId="formBasicEmail">
                    
                    <Form.Control type="text" placeholder="Weight" />
                    
                  </Form.Group>

                 
                  <Button variant="primary" type="submit">
                    Set
                  </Button>
                  <br></br><br></br>

                <h6 className="mb=2">Update Your Height</h6>

                <Form.Group className="mb-3" controlId="formBasicPassword">
                   
                    <Form.Control type="text" placeholder="Height" />
                  </Form.Group>
                  


                  <Button variant="primary" type="submit">
                    Set
                  </Button>
                  <br></br><br></br>

                </Form>

          </div>
          </div>



          <h2 className="mx=2">Goals</h2>
          <div className=" background-custom">
          <div className="mx-2">
          <h6 className="mb=2">Update your weight goals</h6>
                          <Form>
                  <Form.Group className="mb-3" controlId="formBasicEmail">
                    
                    <Form.Control type="text" placeholder="Weight goal" />
                    
                  </Form.Group>

                 
                  <Button variant="primary" type="submit">
                    Set
                  </Button>
                  <br></br><br></br>

                <h6 className="mb=2">Update Your Daily Calories Intake Goal</h6>

                <Form.Group className="mb-3" controlId="formBasicPassword">
                   
                    <Form.Control type="text" placeholder="Calorie Intake Goal" />
                  </Form.Group>
                  


                  <Button variant="primary" type="submit">
                    Set
                  </Button>
                  <br></br><br></br>

                </Form>

          </div>
          </div>


          <h2 className="mx=2">Notifications </h2>
        <div className=" background-custom">
        <div className="mx-2">
        <label>
                    <input type="checkbox"/> Receive updates via Email
                </label>
                    
          
                <br></br><br></br>


        </div>
        </div>
          




      </div>




























    </div>
  );
}


function Section(props) {
  const config = {
      defaultExpanded: props.defaultExpanded || false,
      collapsedHeight: props.collapsedHeight || 0
  };
  const { getCollapseProps, getToggleProps, isExpanded } = useCollapse(config);
return (
  <div className="collapsible">
      <div className="header" {...getToggleProps()}>
          <div className="title">{props.title}</div>
          <div className="icon">
              <i className={'fas fa-chevron-circle-' + (isExpanded ? 'up' : 'down')}></i>
          </div>
      </div>
      <div {...getCollapseProps()}>
          <div className="content">
              {props.children}
          </div>
      </div>
  </div>
  );
}

export default UserSettingsPage;
