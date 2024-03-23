/* eslint-disable react/jsx-no-undef */
import {  useEffect, useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchCities } from '../Store/index';
import DeleteComponent from './DeleteComponent';
import UpdateCity from './UpdateCity';
import AddCity from './AddCity';

function FetchCities() {
    const dispatch = useDispatch();
    const [formData, setFormData] = useState(false);
    const cities = useSelector(state => state.city.cities);


    useEffect(() => {
        dispatch(fetchCities());
    }, [dispatch]);
    
        
    const handleAddCity = () => {
       setFormData(true);
    }


    return (
        <>
            <h2>Cities List</h2>
            <button onClick={handleAddCity}>Add Cities</button>
           
                {formData && <AddCity />}
           
            <ul>
                {cities.map((city, index) => (
                    <li key={index}>{city.cityName}
                        <span><DeleteComponent id={city.cityId} /></span>
                        <span><UpdateCity id={city.cityId} /></span>
                    </li>
                ))}
            </ul>
        </>
    );
}

export default FetchCities;
