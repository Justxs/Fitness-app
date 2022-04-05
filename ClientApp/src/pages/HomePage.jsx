import fitnessImg from '../icons/fitnessPhoto.png';
import '../custom.scss';
import { Button } from 'react-bootstrap'

function HomePage() {
  return (
    <div className="d-flex justify-content-center">
      <div className="d-flex flex-column justify-content-center bg-light mt-5 p-5">
        <h1 className='text-primary'>Welcome to SportyPal!</h1>
        <p>A pal that you need to achieve your goals. With this website you will be able
          to see your progress and change your routine wich will help you get your wanted 
          results.
        </p>
        <img className='img-fluid' src={fitnessImg}  alt="Fitness" />
        <Button variant="primary" size="lg"><b className='text-light'>Get started</b></Button>
      </div>
    </div>
  );
}

export default HomePage;
