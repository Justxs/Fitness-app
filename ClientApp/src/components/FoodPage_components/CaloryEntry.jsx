import React from 'react'
import { Col, Form, Row, Button } from 'react-bootstrap'
import { useState } from "react";
import EatenFoodList from './EatenFoodList'

function CaloryEntry() {
  const [list, setList] = useState([]);
  

  const [meal, setValue] = useState("");
  const [cal, setCal] = useState("");

  const addToList = () => {

    let tempArr = list;

    let mealArr = list;

    mealArr.push(meal);
    mealArr.push(cal);
    tempArr.push(mealArr);

    setList(tempArr);

    setValue("");

  };

 

  const deleteItem = (index) => {

    let temp = list.filter((item, i) => i !== index);

    setList(temp);

  };

  return (
    <div className='Calory_entry_component'>
      <Form className='bg-light m-5 p-3'>
        <Form.Group className="m-3" controlId="formGroupMeal">
          <Form.Label>Meal</Form.Label>
          <Form.Control value={meal} onChange={(e) =>setValue(e.target.value)} required placeholder="Example: Steak" />
          <Form.Text>*Required</Form.Text>
        </Form.Group>

        <Form.Group className="m-3" controlId="formGroupCalories">
          <Form.Label>Calories (Kcal)</Form.Label>
          <Form.Control value={cal} onChange={(f) =>setCal(f.target.value)} required type='number' min={0} placeholder="0" />
          <Form.Text>*Required</Form.Text>
        </Form.Group>
        
        <Row>
          <Col md={4}>
            <Form.Group className="m-3" controlId="formGroupProteins">
              <Form.Label>Proteins (grams)</Form.Label>
              <Form.Control type='number' min={0} placeholder="0" />
            </Form.Group>
          </Col>
          <Col md={4}>
            <Form.Group className="m-3" controlId="formGroupCarbohydrates">
              <Form.Label>Carbohydrates (grams)</Form.Label>
              <Form.Control type='number' min={0} placeholder="0" />
            </Form.Group>
          </Col>
          <Col md={4}>
            <Form.Group className="m-3" controlId="formGroupFats">
              <Form.Label>Fats (grams)</Form.Label>
              <Form.Control type='number' min={0} placeholder="0" />
            </Form.Group>
          </Col>
        </Row>
        <Row className="m-3">
          <Button onClick={addToList} variant="primary" size="lg" type="submit">
            <b className='text-light'>Submit meal</b>
          </Button>
        </Row>
      </Form>





      <div className='Calory_entry_component'>
      
      <Form className='bg-light m-5 p-3'>

      <Form.Label>Meal history</Form.Label>

      <Row>
          <Col md={2}>
            <Form.Group className="m-3" controlId="formGroupProteins">
              <Form.Label>Meal</Form.Label>
            
            </Form.Group>
          </Col>
          <Col md={2}>
            <Form.Group className="m-3" controlId="formGroupCarbohydrates">
              <Form.Label>Calories (Kcal)</Form.Label>
              
            </Form.Group>
          </Col>
          <Col md={2}>
            <Form.Group className="m-3" controlId="formGroupFats">
              <Form.Label>Proteins (grams)</Form.Label>
              
            </Form.Group>
          </Col>
          <Col md={2}>
            <Form.Group className="m-3" controlId="formGroupFats">
              <Form.Label>Carbohydrates (grams)</Form.Label>
              
            </Form.Group>
          </Col>
          <Col md={2}>
            <Form.Group className="m-3" controlId="formGroupFats">
              <Form.Label>Fats (grams)</Form.Label>
              
            </Form.Group>
          </Col>
          <Col md={2}>
            <Form.Group className="m-3" controlId="formGroupFats">
              
              
            </Form.Group>
          </Col>
        </Row>
        
          
       







{/* <ul>

  {list.length > 0 &&

    list.map((item, i) => <li >{item} <Button onClick={() => deleteItem(i)} variant="primary" size="sm" type="submit">
    <b className='text-light'>Delete</b>
  </Button></li>)}
    

</ul> */}



<ul>

  {list.length > 0 &&

    list.map((item, i) => <li > <Row>
    <Col md={2}>
      <Form.Group className="m-3" controlId="formGroupProteins">
        <Form.Label>{item[0]}</Form.Label>
      
      </Form.Group>
    </Col>
    <Col md={2}>
      <Form.Group className="m-3" controlId="formGroupCarbohydrates">
        <Form.Label>{item[1]}</Form.Label>
        
      </Form.Group>
    </Col>
    <Col md={2}>
      <Form.Group className="m-3" controlId="formGroupFats">
        <Form.Label>Proteins (grams)</Form.Label>
        
      </Form.Group>
    </Col>
    <Col md={2}>
      <Form.Group className="m-3" controlId="formGroupFats">
        <Form.Label>Carbohydrates (grams)</Form.Label>
        
      </Form.Group>
    </Col>
    <Col md={2}>
      <Form.Group className="m-3" controlId="formGroupFats">
        <Form.Label>Fats (grams)</Form.Label>
        
      </Form.Group>
    </Col>
    <Col md={2}>
      <Form.Group className="m-3" controlId="formGroupFats">
      <Button onClick={() => deleteItem(i)} variant="primary" size="sm" type="submit">
    <b className='text-light'>Delete</b>
  </Button>
        
      </Form.Group>
    </Col>
  </Row></li>)}
    

</ul>



</Form>
</div></div>









    

      

    




  );
}

export default CaloryEntry