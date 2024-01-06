import React from "react";
import Header from "./components/header";
import "./Css/App.css";
import ToTheDiffSections from "./components/ToTheDiffSections";
import AdvertiseYourBrand from "./components/AdvertiseYourBrand";

function App() {
  return (
    <div className="App">
      <div className="header-container">
        <Header />
      </div>
      <div className="body-container">
        <div className="section-banner">
          <ToTheDiffSections />
        </div>
        <div className="advertsing-section">
          <AdvertiseYourBrand />
        </div>
      </div>
    </div>
  );
}

export default App;
