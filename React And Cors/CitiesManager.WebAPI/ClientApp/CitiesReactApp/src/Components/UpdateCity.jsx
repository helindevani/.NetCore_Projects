/* eslint-disable react/prop-types */
import { useState } from 'react';
import { useDispatch } from 'react-redux';
import { updateCity } from '../Store/index';

// eslint-disable-next-line no-unused-vars
const UpdateCity=({id}) =>
{
    const dispatch = useDispatch();
    const [onclickButton, setOnclickButton] = useState(false);
    const [newCityName, setNewCityName] = useState('');

    const handleShow = () => {
        setOnclickButton(true);
    }

    const handleUpdate = (e) => {
        e.preventDefault();
        dispatch(updateCity({ cityId:id, cityName: newCityName }));
        setNewCityName('');
    };

    return (
        <>
            <button onClick={handleShow}>Update City</button>
            {onclickButton && <form onSubmit={handleUpdate}>
                
                <div>
                    <label htmlFor="newCityName">New City Name:</label>
                    <input
                        type="text"
                        id="newCityName"
                        value={newCityName}
                        onChange={(e) => setNewCityName(e.target.value)}
                    />
                </div>
                <button type="submit">Update City</button>
            </form> }
           
           
            </>

    );
  
};
export default UpdateCity;
