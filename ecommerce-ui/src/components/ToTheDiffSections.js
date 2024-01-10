import React from 'react';
import "../Css/ToTheDiffSection.css"

export default function ToTheDiffSections() {
  return <div className="main-container">
    <div className='accessories-section'>
        <img src={'/images/ToTheSectionImages/accessories1.jpg'} alt="abc" height={554} width={399} />
    </div>
    <div className="mid-section">
        <div className="clothing-section">
            <img src="images/ToTheSectionImages/hoddie.jpg" alt="abc" height={275}width={399} />
        </div>
        <div className="electronics-section">
            <img src="images/ToTheSectionImages/banner4.jpg" alt="abc" height={275} width={399} />

        </div>
    </div>
    <div className="mobile-section">
        <img src="images/ToTheSectionImages/banner2.jpg" alt="abc" height={554} width={399} />
    </div>
  </div>;
}
