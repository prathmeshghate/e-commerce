import React from 'react';
import "../Css/ToTheDiffSection.css"

export default function ToTheDiffSections() {
  return <div className="main-container">
    <div className='accessories-section'>
        <img src={require('../static image/ToTheSectionImages/accessories1.jpg')} alt="abc" height={554} width={399} />
    </div>
    <div className="mid-section">
        <div className="clothing-section">
            <img src={require("../static image/ToTheSectionImages/hoddie.jpg")} alt="abc" height={275}width={399} />
        </div>
        <div className="electronics-section">
            <img src={require("../static image/ToTheSectionImages/banner4.jpg")} alt="abc" height={275} width={399} />

        </div>
    </div>
    <div className="mobile-section">
        <img src={require('../static image/ToTheSectionImages/banner2.jpg')} alt="abc" height={554} width={399} />
    </div>
  </div>;
}
