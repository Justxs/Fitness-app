import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import AppRoutes from './components/routing/AppRoutes';

function App() {
  if(localStorage.getItem('isLoggedIn') === null){
    localStorage.setItem('isLoggedIn', 'true');
  }
  return (
      <AppRoutes isLoggedIn={localStorage.getItem('isLoggedIn') === 'true'}/>
  );
}

export default App;