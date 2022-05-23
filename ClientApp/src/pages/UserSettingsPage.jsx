import "../custom.scss";
import React from "react";
import { Form, Col, Row, Button } from "react-bootstrap";

function UserSettingsPage() {
  return (
    <div className="Settings_Page">
      <div className="bg-light m-5 p-3">
        <Row className="m-3">
          <h2 className="mx=2">Account</h2>
          <Col md={6}>
            <h6>Change Email Address</h6>
            <Form className="mb-1">
              <Form.Group className="mb-1" controlId="formBasicEmail">
                <Form.Label>New Email address</Form.Label>
                <Form.Control type="email" placeholder="Enter email" />
              </Form.Group>

              <Button variant="primary" type="submit">
                <b className="text-light">Change</b>
              </Button>
            </Form>
          </Col>
          <Col md={6}>
            <h6>Change Password</h6>
            <Form className="mb-1">
              <Form.Group className="mb-1" controlId="formBasicPassword">
                <Form.Label>Password</Form.Label>
                <Form.Control type="password" placeholder="Password" />
              </Form.Group>
              <Form.Group className="mb-1" controlId="formBasicEmail2">
                <Form.Label>Confirm Password</Form.Label>
                <Form.Control type="password" placeholder="Password" />
              </Form.Group>

              <Button variant="primary" type="submit">
                <b className="text-light">Change</b>
              </Button>
            </Form>
          </Col>
        </Row>
        <Row className="m-3">
          <Col md={6}>
            <h2 className="mx=2">Body data</h2>
            <h6>Update your weight</h6>
            <Form className="my-2">
              <Form.Group className="mb-1" controlId="formBasicWeight">
                <Form.Control type="text" placeholder="Weight" />
              </Form.Group>
              <Button variant="primary" type="submit">
                <b className="text-light">Set</b>
              </Button>
              <h6>Update Your Height</h6>
              <Form.Group className="mb-1" controlId="formBasicHeight">
                <Form.Control type="text" placeholder="Height" />
              </Form.Group>
              <Button variant="primary" type="submit">
                <b className="text-light">Set</b>
              </Button>
              <h6 >Update your age</h6>
                <Form.Group className="mb-1" controlId="formBasicAge">
                  <Form.Control type="text" placeholder="Age" />
                </Form.Group>
                <Button variant="primary" type="submit">
                  <b className="text-light">Set</b>
                </Button>
            </Form>
          </Col>

          <Col md={6}>
            <h2 className="mx=2">Goals</h2>
            <h6 className="mb=2">Update your weight goals</h6>
            <Form className="mb-3">
              <Form.Group className="mb-1" controlId="formBasicWeight2">
                <Form.Control type="text" placeholder="Weight goal" />
              </Form.Group>
              <Button variant="primary" type="submit">
                <b className="text-light">Set</b>
              </Button>
              <h6>Update Your Daily Calories Intake Goal</h6>

              <Form.Group className="mb-1" controlId="formBasicCalories">
                <Form.Control type="text" placeholder="Calorie Intake Goal" />
              </Form.Group>

              <Button variant="primary" type="submit">
                <b className="text-light">Set</b>
              </Button>
            </Form>
          </Col>
        </Row>
      </div>
    </div>
  );
}

export default UserSettingsPage;
