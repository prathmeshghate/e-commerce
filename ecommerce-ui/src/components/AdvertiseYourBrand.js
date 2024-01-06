import React from "react";
import "../Css/AdvertiseYourBrand.css";

export default function AdvertiseYourBrand() {
  return (
    <div className="main-section">
      <div className="image-section">
        <img
          src={require("../static image/advertiseYourBrand/BrandAdvertisementImage1.png")}
          className="advertiseing-image-1"
          alt="AB"
          height={300}
          width={290}
        />
        <img
          src={require("../static image/advertiseYourBrand/BrandAdvertisementImage2.png")}
          className="advertiseing-image-2"
          alt="AB"
          height={300}
          width={290}
        />
      </div>
      <div className="right-section">
        <div className="brand-desc">
          <div className="title-section">GET KNOWN!!</div>
          <div className="desc-section">Advertise Your Brand Here</div>
        </div>
        <div className="advertise-section">
          <button type="button" className="advertise-cta">
            Click Here!
          </button>
        </div>
      </div>
    </div>
  );
}
