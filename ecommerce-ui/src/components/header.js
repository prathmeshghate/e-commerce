import React from "react";
import { Link } from "react-router-dom/cjs/react-router-dom";
import "../Css/header.css";
import { BsSearch } from "react-icons/bs";
import { CgProfile } from "react-icons/cg";

export default function header() {
  return (
    <div className="header-main">
      <Link to="/">
        <div className="logo-container">
          <img
            src="/images/ShopKartLogo.png"
            alt="abc"
            className="logo-main"
            height={100}
            width={100}
          />
        </div>
      </Link>
      <div className="navigation-tags">
        <div className="header-contents">
          <div className="navigation-menu">
            <Link to={`/${"Clothing"}`}>
              <div className="clothing-container">Clothing</div>
            </Link>
            <Link to={`/${"Electronics"}`}>
              <div className="electronics-container">Electronics</div>
            </Link>
            <Link to={`/${"Accessories"}`}>
              <div className="accessories-container">Accessories</div>
            </Link>
          </div>
          <div className="search-container">
            <input className="search-box" />
            <BsSearch className="search-logo" size={30} />
          </div>
        </div>
        {true ? (
          <div className="login-signup-section">
            <Link>
              <div className="login-section">Log In</div>
            </Link>
            <div className="or-section">or</div>
            <Link>
              <div className="signup-section">Sign Up</div>
            </Link>
          </div>
        ) : null}
        <div className="profile-section">
          <CgProfile size={30} />
        </div>
      </div>
    </div>
  );
}
