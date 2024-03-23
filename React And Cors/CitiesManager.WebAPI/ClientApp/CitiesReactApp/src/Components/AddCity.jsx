import  { useState} from 'react';
import { useDispatch } from 'react-redux';
import {  addCity} from '../Store/index';


function AddCity() {
    const dispatch = useDispatch();
    const [cityName, setCityName] = useState('');


    const generateGUID = () => {
        return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
            var r = (Math.random() * 16) | 0,
                v = c === 'x' ? r : (r & 0x3) | 0x8;
            return v.toString(16);
        });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        const cityId = generateGUID(); // Generate GUID for city ID
        dispatch(addCity({ cityId, cityName }));
        setCityName('');
    };


    return (
        <>
            <div>
                <h2>Add City</h2>
               
                    <div>
                        <label htmlFor="cityName">City Name:</label>
                        <input
                            type="text"
                            id="cityName"
                            value={cityName}
                            onChange={(e) => setCityName(e.target.value)}
                            required                           
                            
                        />
                    </div>
                    <button type="submit" onClick={handleSubmit}>Add City</button>
               
            </div>

            
        </>
    );
}

export default AddCity;
