import '../src/custom.scss';
import Header from './components/Header';
import AppRoutes from './components/routing/AppRoutes';
import useAuth  from './hooks/useAuth';

function App() {
  const { username } = useAuth();
  return (
    <>
      <Header isLoggedIn={ username !== undefined }/>
      <AppRoutes isLoggedIn={ username !== undefined }/>
    </>
  );
}

export default App;
