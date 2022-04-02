import AppRoutes from './components/routing/AppRoutes';
import './custom.scss';

function App() {
  if(localStorage.getItem('isLoggedIn') === null){
    localStorage.setItem('isLoggedIn', 'true');
  }
  return (
      
      <AppRoutes isLoggedIn={localStorage.getItem('isLoggedIn') === 'true'}/>
  );
}

export default App;
