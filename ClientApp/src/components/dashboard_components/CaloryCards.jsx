import { Card, CardGroup, Row, Col } from 'react-bootstrap';
import bone from '../../icons/bone.png';
import meat from '../../icons/meat.png';
import goal from '../../icons/goal.png';

function CaloryCards() {
    //placeholder code
    let ConsumedCal = 1500;
    let Target = 2000;
    let RemainingCal = Target - ConsumedCal;
  
    const Style ={
      img: {
        width:50, 
        backgroundColor:"#FCFCFD"
      },
      calories: {
        color: "#00FF00"
      }
    }
    
    if(RemainingCal <=100){
        Style.calories.color = "red";
    }
  
    return (
      <div className="Calory_cards">
        <CardGroup className='m-2 md-2'>
          <Card className='bg-light m-4 p-3'>
            <Card.Body>
              <Row>
                <Col ><Card.Img src={bone} style={Style.img} /></Col>
                <Col md={10}>
                  <Card.Title>Consumed calories</Card.Title>
                  <Card.Title>{ConsumedCal}</Card.Title>
                </Col>
              </Row>
            </Card.Body>
          </Card>
          
          <Card className='bg-light m-4 p-3'>
            <Card.Body>
            <Row>
              <Col><Card.Img src={meat} style={Style.img} /></Col>
              <Col md={10}>
                <Card.Title >Remaining calories</Card.Title>
                <Card.Title style={Style.calories}>{Target-ConsumedCal}</Card.Title>
              </Col>
            </Row>
            
            </Card.Body>
          </Card>
          
          <Card className='bg-light m-4 p-3'>
            <Card.Body>
            <Row>
              <Col><Card.Img src={goal} style={Style.img} /></Col>
              <Col md={10}>
                <Card.Title>Target calories</Card.Title>
                <Card.Title>{Target}</Card.Title>
              </Col>
            </Row>
            </Card.Body>
          </Card>
        </CardGroup>
      </div>
    );
  }
  
  export default CaloryCards;
  