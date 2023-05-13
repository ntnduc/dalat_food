import 'swiper/css';
import 'swiper/css/navigation';
import './style/dalat-swiper.scss';

import PropTypes from 'prop-types';
import React from 'react';
import { Navigation } from 'swiper';
import { Swiper, SwiperProps, SwiperSlide } from 'swiper/react';

import DaLatIcon from './DaLatIcon';

const TypeViewRender = {
    mobile: 'mobile',
    ipad: 'ipad',
    laptop: 'laptop',
    desktop: 'desktop'
} as const;

type ObjValue<T> = T[keyof T];
type TypeView = ObjValue<typeof TypeViewRender>

interface Props extends SwiperProps {
    typeViewRender?: TypeView
}

const DaLatSwiper = (props: Props) => {

    return (
        <div className='wrap-dalat-swiper'>
            <Swiper
                modules={[Navigation]}
                speed={600}
                navigation={{
                    nextEl: '.swiper-button-next',
                    prevEl: '.swiper-button-prev',
                }}
                spaceBetween={20}
                className={`dalat-swiper ${props.className}`}
                {...props}
            >
                {React.Children.map(props.children, (child) => {
                    return <SwiperSlide>{child}</SwiperSlide>;
                })}
            </Swiper>
            <div className='swiper-button-prev'>
                <DaLatIcon iconType='left' style={{ fontSize: 12 }} />
            </div>
            <div className='swiper-button-next'>
                <DaLatIcon iconType='right' style={{ fontSize: 12 }} />
            </div>
        </div>
    );
};

DaLatSwiper.propType = {
    children: PropTypes.node.isRequired
};

export default DaLatSwiper;
