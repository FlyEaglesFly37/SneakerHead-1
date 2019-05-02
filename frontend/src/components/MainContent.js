import React, { Component } from 'react';
import img1 from '../Jordan1.svg';
import img2 from '../Zoom.svg';
import img3 from '../Bron.svg';
import img4 from '../shoe.jpg';
import 'bootstrap/dist/css/bootstrap.css';

export default class MainContent extends Component {
    render() {
        return (
            <div>
                <div id="carouselControls" className="carousel slide" data-ride="carousel">
                    <div className="carousel-inner">
                        <div class="carousel-item active">
                            <img scr={img4} className="d-block w-100" alt="Jordan 1 Retro" />
                        </div>
                        <div class="carousel-item">
                            <img scr={img2} className="d-block w-100" alt="Nike Zoom Canvas" />
                        </div>
                        <div class="carousel-item">
                            <img scr={img3} className="d-block w-100" alt="Lebron somethings" />
                        </div>
                    </div>
                    <a className="carousel-control-prev" href="#carouselControls" role="button" data-slide="prev">
                        <span className="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span className="sr-only">Previous</span>
                    </a>
                    <a className="carousel-control-next" href="#carouselControls" role="button" data-slide="next">
                        <span className="carousel-control-next-icon" aria-hidden="true"></span>
                        <span className="sr-only">Next</span>
                    </a>
                </div>
            </div>
        )
    }
}