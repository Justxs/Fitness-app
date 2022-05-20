import '../src/custom.scss';
import AppRoutes from './components/routing/AppRoutes';
import useAuth  from './hooks/useAuth';

function App() {
  const { username } = useAuth();
  //console.log(username);
  return (
      <AppRoutes isLoggedIn={ username !== undefined }/>
  );
}

export default App;
