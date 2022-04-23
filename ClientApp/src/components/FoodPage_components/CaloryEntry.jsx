import React from 'react'
import { Col, Form, Row, Button } from 'react-bootstrap'

function CaloryEntry() {
  return (
    <div className='Calory_entry_component'>
      <Form className='bg-light m-5 p-3'>
        <Form.Group className="m-3" controlId="formGroupMeal">
          <Form.Label>Meal</Form.Label>
          <Form.Control required placeholder="Example: Steak" />
          <Form.Text>*Required</Form.Text>
        </Form.Group>

        <Form.Group className="m-3" controlId="formGroupCalories">
          <Form.Label>Calories (Kcal)</Form.Label>
          <Form.Control required type='number' min={0} placeholder="0" />
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
          <Button variant="primary" size="lg" type="submit">
            <b className='text-light'>Submit meal</b>
          </Button>
        </Row>
      </Form>
    </div>
  )
}

export default CaloryEntry