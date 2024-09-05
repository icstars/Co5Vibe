import React from 'react'
import { Link } from 'react-router-dom';
import './NavBar.css'

const Navbar= () => {
    return (
<>
<div className="App">
<nav className="navbar navbar-expand-lg navbar-light navbar-logo fixed-top">
  <div className="container">
    <Link className="navbar-brand" to={'/sign-in'}>
      Evaluate Pro
    </Link>
    <div className="collapse navbar-collapse" id="navbarTogglerDemo02">
      <ul className="navbar-nav ml-auto">
        <li className="nav-item">
          <Link className="nav-link" to={'/sign-in'}>
            Login
          </Link>
        </li>
      </ul>
    </div>
  </div>
</nav>
</div>
</>  
    )
}
export default Navbar;