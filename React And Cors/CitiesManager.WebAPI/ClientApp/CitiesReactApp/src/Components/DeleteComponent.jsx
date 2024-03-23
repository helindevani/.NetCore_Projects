
import { useDispatch } from 'react-redux';
import { deleteCity } from '../Store/index';

// eslint-disable-next-line react/prop-types
const DeleteComponent = ({ id }) => 
{
    
    const dispatch = useDispatch();

    const handleDelete = () => {
        dispatch(deleteCity(id));
    };

    return (
        
            <button onClick={handleDelete}>Delete</button>
       
    );
};

export default DeleteComponent;