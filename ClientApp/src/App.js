import AppRoutes from './components/routing/AppRoutes';
import { useAuth } from './hooks/useAuth';
import './custom.scss';

function App() {
  const { isLoggedIn } = useAuth();
  return (
      <AppRoutes isLoggedIn={isLoggedIn}/>
  );
}

export default App;
