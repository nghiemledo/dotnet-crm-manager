import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.min.js';
import { QueryClient, QueryClientProvider } from 'react-query';
import { Route, Routes } from 'react-router-dom';
import { MainLayout } from './common/Layout/main.layout';
import { CustomerPage } from './pages/customer/customer.page';
import { CustomerCreatePage } from './pages/customer/customer.create';

function App() {
  const queryClient = new QueryClient();
  return (
    <>
      <QueryClientProvider client={queryClient}>
        <Routes>
          <Route path="/" element={<MainLayout />}>
            <Route path="/customers" element={<CustomerPage />} />
            <Route path="/customers/create" element={<CustomerCreatePage />} />
          </Route>
        </Routes>
      </QueryClientProvider>
    </>
  );
}

export default App;
