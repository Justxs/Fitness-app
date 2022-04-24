import '../custom.scss';
import React, { useEffect, useState } from "react";
import { Button } from 'react-bootstrap';
import useCollapse from 'react-collapsed';
import '../settings.css';


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
    




   

    

    <div className="preferences">
             <Section title="General" defaultExpanded="true">
                <label>
                    <input type="checkbox"/> Use dark theme
                </label>
                
                <br/><br/>
            </Section>
             <Section title="Account">
             
            <ul className="list-group">
              <li className="list-group-item mb-2">
                <h6 className="font-weight-bold">Change Email Address</h6>
                <p>Update your email address</p>
                <form>
                <label className="mx-2">New email:
                <input type="text" />
                </label>
                <Button className="ml-1">Change</Button>
                </form>

              </li>

              <li className="list-group-item mb-2">
                <div className="font-weight-bold">
                <h6 className="font-weight-bold">Change password</h6>
                <p>Change your current password</p>
                <form>
                <label className="mx-2">New password: 
                <input type="password" className="mx-5" />
                </label>
                <label className="mx-2">Confirm password: 
                <input type="password" className="mx-4" />
                </label>
                <Button className="ml-1">Change</Button>
                </form>
                </div>

              </li>



            </ul>

                        
               
            
            </Section>
            <Section title="Body Data">
            <ul className="list-group">
              <li className="list-group-item mb-2">
                <h6 className="font-weight-bold">Weight</h6>
                <p>Update or set your weight</p>
                <form>
                <label className="mx-2">Weight:
                <input type="text" />
                </label>
                <Button className="ml-1">Set</Button>
                </form>

              </li>

              <li className="list-group-item mb-2">
                <h6 className="font-weight-bold">Height</h6>
                <p>Update or set your height</p>
                <form>
                <label className="mx-2">Height:
                <input type="text" />
                </label>
                <Button className="ml-1">Set</Button>
                </form>

              </li>



            </ul>

                        
               
            </Section>

            <Section title="Goals">
            <ul className="list-group">
              <li className="list-group-item mb-2">
                <h6 className="font-weight-bold">Weight Goal</h6>
                <p>Update or set your weight goal</p>
                <form>
                <label className="mx-2">Weight Goal:
                <input type="text" />
                </label>
                <Button className="ml-1">Set</Button>
                </form>

              </li>

              <li className="list-group-item mb-2">
                <h6 className="font-weight-bold">Calorie Intake Goal</h6>
                <p>Update or set your calorie intake goal</p>
                <form>
                <label className="mx-2">Daily calories:
                <input type="text" />
                </label>
                <Button className="ml-1">Set</Button>
                </form>

              </li>



            </ul>

                        
               
            </Section>







            <Section title="Notifications" collapsedHeight="32">
                
                <br/><br/>
                <label>
                    <input type="checkbox"/> Notify me about my progress via Email
                </label>
                <br/><br/>
            </Section>
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
