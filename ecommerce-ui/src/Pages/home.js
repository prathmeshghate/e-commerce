import React from "react";
import "../Css/home.css";
import ToTheDiffSections from "../components/ToTheDiffSections";
import AdvertiseYourBrand from "../components/AdvertiseYourBrand";
import DealOfTheDay from "../components/DealOfTheDay";

export default function home() {
  return (
    <div className="home-container">
      <div className="section-banner">
        <ToTheDiffSections />
      </div>
      <div className="advertsing-section">
        <AdvertiseYourBrand />
      </div>
      <div className="deals-container">
        <DealOfTheDay />
      </div>
    </div>
  );
}
