import '../src/custom.scss';
import AppRoutes from './components/routing/AppRoutes';
import { useAuth } from './hooks/useAuth';

function App() {
  const { isLoggedIn } = useAuth();
  return (
      <AppRoutes isLoggedIn={isLoggedIn}/>
  );
}

export default App;
