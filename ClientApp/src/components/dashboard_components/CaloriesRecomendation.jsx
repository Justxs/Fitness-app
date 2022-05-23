import {Row, Col} from "react-bootstrap";


function CaloriesRecomendation() {
  // harcoded data
  let weight = 87;
  let height = 159;
  let age = 22;
  // Calculated calories to eat for man to achieve wanted goals
  let caloriesToMaintain = Math.round(13.397 * weight + 4.799 * height - 5 * age + 88.362);
  let caloriesToMildLose = caloriesToMaintain - 200;
  let caloriesToLose = caloriesToMaintain - 500;
  let caloriesToExtreme = caloriesToMaintain - 1000;
  const Style = {
    calories: {
      color: "#79B2FE",
      TextAlign: "center",
    },
    mild: {
      color: "#79B2FE",
    },
    lose: {
      color: "#79B2FE",
    },
    extreme: {
      color: "#79B2FE",
    },
  };
  // check if calories are under 1500 calories
  if (caloriesToMaintain <= 1500) {
    Style.calories.color = "red";
  }
  if (caloriesToMildLose <= 1500) {
    Style.mild.color = "red";
  }
  if (caloriesToLose <= 1500) {
    Style.lose.color = "red";
  }
  if (caloriesToExtreme <= 1500) {
    Style.extreme.color = "red";
  }

  return (
    <div>
      <div className="bg-light p-3 ">
        <h2>Calculated calories consumtion:</h2>
        <Col>
          <Row className="my-2">
            <h3>Maintain weight: <b style={Style.calories}>{caloriesToMaintain}</b></h3>
          </Row>
          <Row className="my-2">
            <h3>Mild weight loss (0.25kg/week): <b style={Style.mild}>{caloriesToMildLose}</b></h3>
          </Row>
          <Row className="my-2">
            <h3>Weight loss (0.5kg/week): <b style={Style.lose}>{caloriesToLose}</b></h3>
          </Row>
          <Row className="my-2">
            <h3>Extreme weight loss (1kg/week): <b style={Style.extreme}>{caloriesToExtreme}</b></h3>
          </Row>
          <Row className="my-2">
            <b>These calories are calculated for sedentary lifestyle if you are active you mught need more calories to maintain your weight.<br></br> You shouldn't eat less than <span style={{color: "red"}}>1500 calories</span>. Please consult with a doctor if you want to eat less.</b>
          </Row>
        </Col>
      </div>
    </div>
  );
}

export default CaloriesRecomendation;
