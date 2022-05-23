import React from 'react'
import { useState } from "react";
import { Form, Button } from 'react-bootstrap'

function EatenFoodList() {
  const [list, setList] = useState([]);

  const [value, setValue] = useState("");

 

  const addToList = () => {

    let tempArr = list;

    tempArr.push(value);

    setList(tempArr);

    setValue("");

  };

 

  const deleteItem = (index) => {

    let temp = list.filter((item, i) => i !== index);

    setList(temp);

  };

 

  return (

    <div className="App">

      <input

        type="text"

        value={value}

        onChange={(e) => setValue(e.target.value)}

      />{" "}
      

      <button onClick={addToList}> Click to Add </button>

      <Form.Group className="m-3" controlId="formGroupMeal">
          <Form.Label>Entry</Form.Label>
          <Form.Control value={value} onChange={(e) => setValue(e.target.value)} required placeholder="Example: Steak" />
          <Form.Text>*Required</Form.Text>
        </Form.Group>

        <Button onClick={addToList}> 
            <b className='text-light'>Submit meal</b>
          </Button>

      <ul>

        {list.length > 0 &&

          list.map((item, i) => <li >{item} <Button onClick={() => deleteItem(i)} variant="primary" size="sm" type="submit">
          <b className='text-light'>Delete</b>
        </Button></li>)}
          

      </ul>

    </div>

  );




}

export default EatenFoodList