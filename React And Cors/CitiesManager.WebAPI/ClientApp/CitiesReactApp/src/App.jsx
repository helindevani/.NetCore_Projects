import { createRoutesFromElements, Route, createBrowserRouter, RouterProvider } from 'react-router-dom';
import './App.css'
import FetchCities from './Components/FetchCities';


function App() {
    const routerDefinitions = createRoutesFromElements(
        <Route>
            <Route path="/" element={<FetchCities />} />
        </Route>);

    const router=createBrowserRouter(routerDefinitions);

    return (
         <div className="container">
            <RouterProvider router={router} />
           
        </div>
    );
}

export default App
