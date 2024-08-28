import React, { useState, useEffect } from 'react';
import axios from 'axios';

const User = () => {
    const [User, setUser] = useState([]);
    const [UserId, setUserId] = useState();
    const [FirstName, setFirstName] = useState('');
    const [LastName, setLastName] = useState('');
    const [Email, setEmail] = useState('');
    const [Title, setTitle] = useState('');
    

    useEffect(() => {
        axios.get('http://localhost:3000/api/employees')
             .then(response => setUser(response.data))
             .catch(error => console.error(error));
    }, []);

    const addUser = () => {
        axios.post('http://localhost:3000/api/employees',{ FirstName,LastName,Email,User,UserId,Title})
             .then(response => setUser([...User, response.data]))
             .catch(error => console.error(error));        
    };

    return (
        <div className='login-screen'>
            <h1>User</h1>
            <ul>
                {User.map(User => (
                    <li key={User.id}>{User.FirstName}{User.LastName}{User.Email}{User.Title} </li>
                ))}
            </ul>
            <input
                type="text"
                placeholder="User Id"
                value={UserId}
                onChange={e => setUserId(e.target.value)}
            />
            <input
                type="text"
                placeholder="First Name"
                value={FirstName}
                onChange={e => setFirstName(e.target.value)}
            />
            <input
                type="text"
                placeholder="Last Name"
                value={LastName}
                onChange={e => setLastName(e.target.value)}
            />
            <input
                type="email"
                placeholder="Email"
                value={Email}
                onChange={e => setEmail(e.target.value)}
            />
            {/* <input
                type="number"
                placeholder="Score"
                value={Score}
                onChange={e => setScore(e.target.value)}
            /> */}
            <input
                type="text"
                placeholder="Title"
                value={Title}
                onChange={e => setTitle(e.target.value)}
            />
            <button onClick={addUser}>Add User</button>
        </div>         
    );
};

export default User;