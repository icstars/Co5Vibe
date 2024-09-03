import React from 'react';
import NavBar from '../navigations/NavBar';
import 'bootstrap/dist/css/bootstrap.min.css';

const LandingPage = () => {
    return (
        <>
             <NavBar />
        <div className="container-fluid my-5 border">
            <h1>Welcome to our Landing Page!</h1>
            <p>This is the content of the landing page.</p>
        </div>
        </>
    );
};

export default LandingPage;