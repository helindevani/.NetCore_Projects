/* eslint-disable no-unused-vars */
import  { useState } from 'react';

const RegisterForm = () => {
    const [formData, setFormData] = useState({
        personName: '',
        email: '',
        phoneNumber: '',
        password: '',
        confirmPassword: ''
    });
    const [formErrors, setFormErrors] = useState({
        personName: '',
        email: '',
        phoneNumber: '',
        password: '',
        confirmPassword: ''
    });

    const handleChange = (e) => {
        const { name, value } = e.target;
        setFormData({
            ...formData,
            [name]: value
        });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        // You can add form validation logic here
        // For simplicity, I'm assuming the form is always valid
        console.log(formData);
        // Reset form fields after submission
        setFormData({
            personName: '',
            email: '',
            phoneNumber: '',
            password: '',
            confirmPassword: ''
        });
    };

    return (
        <div className="w-75 margin-auto">
            <div className="form-container">
                <h2>Register</h2>
                <form onSubmit={handleSubmit}>
                    <div className="form-field flex">
                        <div className="w-25">
                            <label htmlFor="personName" className="form-label pt">Person Name</label>
                        </div>
                        <div className="flex-1">
                            <input type="text" id="personName" className="form-input" name="personName" value={formData.personName} onChange={handleChange} />
                        </div>
                    </div>
                    {/* Similar fields for email, phone number, password, and confirm password */}
                    <div className="form-field flex">
                        <div className="w-25"></div>
                        <div className="flex-1">
                            <button type="submit" className="button button-green-back">Register</button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    );
};

export default RegisterForm;
