import React, { useEffect } from "react";
import { Col, Form, Row, Button } from "react-bootstrap";
import { useState } from "react";
import FoodProduct from "../../models/FoodProduct";
import FoodProductService from "../../services/FoodProductService";

function CaloryEntry() {
  const foodProductService = new FoodProductService();

  const [list, setList] = useState([]);
  const [meal, setValue] = useState("");
  const [cal, setCal] = useState("");
  const [protein, setProt] = useState("");
  const [chydrats, setChydratsCal] = useState("");
  const [fats, setFats] = useState("");

  useEffect(() => {
    updateList();
  }, [meal, cal, protein, chydrats, fats]);

  async function updateList() {
    let productList = await foodProductService.getFoodProducts();
    setList(productList);
  }

  async function addElement() {
    let product = new FoodProduct(0, meal, cal, protein, chydrats, fats, "");
    await foodProductService.addFoodProduct(product);

    setValue("");
    setCal("");
    setProt("");
    setChydratsCal("");
    setFats("");

    updateList();
  }

  async function deleteElement(id) {
    console.log(id);
    await foodProductService.deleteFoodProduct(id);
    await updateList();
  }

  return (
    <div className="Calory_entry_component">
      <Form className="bg-light m-5 p-3">
        <Form.Group className="m-3" controlId="formGroupMeal">
          <Form.Label>Meal</Form.Label>
          <Form.Control
            value={meal}
            onChange={(e) => setValue(e.target.value)}
            required
            placeholder="Example: Steak"
          />
          <Form.Text>*Required</Form.Text>
        </Form.Group>

        <Form.Group className="m-3" controlId="formGroupCalories">
          <Form.Label>Calories (Kcal)</Form.Label>
          <Form.Control
            value={cal}
            onChange={(f) => setCal(f.target.value)}
            required
            type="number"
            min={0}
            placeholder="0"
          />
          <Form.Text>*Required</Form.Text>
        </Form.Group>

        <Row>
          <Col md={4}>
            <Form.Group className="m-3" controlId="formGroupProteins">
              <Form.Label>Proteins (grams)</Form.Label>
              <Form.Control
                value={protein}
                onChange={(h) => setProt(h.target.value)}
                type="number"
                min={0}
                placeholder="0"
              />
            </Form.Group>
          </Col>
          <Col md={4}>
            <Form.Group className="m-3" controlId="formGroupCarbohydrates">
              <Form.Label>Carbohydrates (grams)</Form.Label>
              <Form.Control
                value={chydrats}
                onChange={(g) => setChydratsCal(g.target.value)}
                type="number"
                min={0}
                placeholder="0"
              />
            </Form.Group>
          </Col>
          <Col md={4}>
            <Form.Group className="m-3" controlId="formGroupFats">
              <Form.Label>Fats (grams)</Form.Label>
              <Form.Control
                value={fats}
                onChange={(l) => setFats(l.target.value)}
                type="number"
                min={0}
                placeholder="0"
              />
            </Form.Group>
          </Col>
        </Row>
        <Row className="m-3">
          <Button
            onClick={() => addElement()}
            variant="primary"
            size="lg"
            type="button"
          >
            <b className="text-light">Submit meal</b>
          </Button>
        </Row>
      </Form>

      <div className="Calory_entry_component">
        <Form className="bg-light m-5 p-3">
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
              <Form.Group
                className="m-3"
                controlId="formGroupFats"
              ></Form.Group>
            </Col>
          </Row>

          {/* <ul>

  {list.length > 0 &&

    list.map((item, i) => <li >{item} <Button onClick={() => 
      (i)} variant="primary" size="sm" type="submit">
    <b className='text-light'>Delete</b>
  </Button></li>)}
    

</ul> */}

          <ul>
            {list?.length > 0 &&
              list.map((item, i) => (
                <li key={item.id}>
                  {" "}
                  <Row>
                    <Col md={2}>
                      <Form.Group className="m-3" controlId="formGroupProteins">
                        <Form.Label>{item.name}</Form.Label>
                      </Form.Group>
                    </Col>
                    <Col md={2}>
                      <Form.Group
                        className="m-3"
                        controlId="formGroupCarbohydrates"
                      >
                        <Form.Label>{item.calories100g}</Form.Label>
                      </Form.Group>
                    </Col>
                    <Col md={2}>
                      <Form.Group className="m-3" controlId="formGroupFats">
                        <Form.Label>{item.proteins100g}</Form.Label>
                      </Form.Group>
                    </Col>
                    <Col md={2}>
                      <Form.Group className="m-3" controlId="formGroupFats">
                        <Form.Label>{item.carbohydrates100g}</Form.Label>
                      </Form.Group>
                    </Col>
                    <Col md={2}>
                      <Form.Group className="m-3" controlId="formGroupFats">
                        <Form.Label>{item.fats100g}</Form.Label>
                      </Form.Group>
                    </Col>
                    <Col md={2}>
                      <Form.Group className="m-3" controlId="formGroupFats">
                        <Button
                          onClick={() => deleteElement(item.id)}
                          variant="primary"
                          size="sm"
                          type="button"
                        >
                          <b className="text-light">Delete</b>
                        </Button>
                      </Form.Group>
                    </Col>
                  </Row>
                </li>
              ))}
          </ul>
        </Form>
      </div>
    </div>
  );
}

export default CaloryEntry;
