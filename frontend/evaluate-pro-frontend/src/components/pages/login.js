import React, { Component } from "react";
import { Link } from "react-router-dom";
import "../navigations/NavBar.css";
import "../misc/login.css";

localStorage.test = null;

export default class Login extends Component {
  constructor(props) {
    super(props);
    this.state = {
      email: "",
      password: "",
    };
  }

  handleSubmit = (event) => {
    event.preventDefault();

    const { email, password } = this.state;

    if (email === "Kevin@example.com" && password === "password") {
      window.location.href = "/Profile";
      localStorage.name = "Kevin Taylor"
      localStorage.title = "Product Engineer Lead"
      localStorage.address = "Chicago,IL"
      localStorage.email = "Kevin@example.com"
    } else if (email === "Demetrius@example.com" && password === "password") {
      window.location.href = "/Profile";
      localStorage.name = "Demetrius Robinson"
      localStorage.title = "Junior Developer"
      localStorage.address = "Chicago,IL"
      localStorage.email = "Demetrius@example.com"
    } else if (email === "Roann@example.com" && password === "password") {
      window.location.href = "/Profile";
      localStorage.name = "Roann Yanes"
      localStorage.title = "Developer Specialist"
      localStorage.address = "Chicago,IL"
      localStorage.email = "Roann@example.com"
    } else {
      alert("Invalid credentials");
    }
  };

  handleChange = (event) => {
    this.setState({ [event.target.name]: event.target.value });
  };

  render() {
    return (
      <div className="login-wrapper">
        <div className="login-box">
          <form onSubmit={this.handleSubmit}>
            <h3>Login</h3>
            <div className="mb-3">
              <label>Email address</label>
              <input
                type="email"
                name="email"
                className="form-control"
                placeholder="Enter email"
                value={this.state.email}
                onChange={this.handleChange}
              />
            </div>
            <div className="mb-3">
              <label>Password</label>
              <input
                type="password"
                name="password"
                className="form-control"
                placeholder="Enter password"
                value={this.state.password}
                onChange={this.handleChange}
              />
            </div>
            <div className="mb-3">
              <div className="custom-control custom-checkbox">
                <input
                  type="checkbox"
                  className="custom-control-input"
                  id="customCheck1"
                />
                <label className="custom-control-label" htmlFor="customCheck1">
                  Remember me
                </label>
              </div>
            </div>
            <div className="d-grid">
              <button type="submit" className="btn btn-primary submitbtn">
                Submit
              </button>
            </div>
            <p className="forgot-password text-right">
              Forgot <a href="#">password?</a>
            </p>
          </form>
        </div>
      </div>
    );
  }
}
