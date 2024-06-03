import 'swiper/css';
import 'swiper/css/navigation';
import './style/dalat-swiper.scss';

import PropTypes from 'prop-types';
import React, { useEffect, useRef, useState } from 'react';
import { Navigation } from 'swiper';
import { Swiper, SwiperProps, SwiperRef, SwiperSlide } from 'swiper/react';

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
    const [childHeight, setChildHeight] = useState<number>(0);
    const swiperRef = useRef<SwiperRef>(null);
    const buttonControllerRef = useRef<HTMLDivElement>(null);

    useEffect(() => {
        const heightChild = swiperRef.current?.swiper.height;
        if (heightChild) {
            setChildHeight(heightChild);
        }
    }, [swiperRef.current?.swiper.height]);

    return (
        <div className='wrap-dalat-swiper'>
            <div className='wrap-controller-swiper' style={{ height: childHeight }}>
                <div className='swiper-button-prev'>
                    <DaLatIcon iconType='left' style={{ fontSize: 12 }} />
                </div>
                <div className='swiper-button-next'>
                    <DaLatIcon iconType='right' style={{ fontSize: 12 }} />
                </div>
            </div>
            <Swiper
                modules={[Navigation]}
                speed={600}
                navigation={{
                    nextEl: '.swiper-button-next',
                    prevEl: '.swiper-button-prev',
                }}
                ref={swiperRef}
                spaceBetween={20}
                className={`dalat-swiper ${props.className}`}
                {...props}
            >
                {React.Children.map(props.children, (child) => {
                    return <SwiperSlide>{child}</SwiperSlide>;
                })}
            </Swiper>
        </div>
    );
};

DaLatSwiper.propType = {
    children: PropTypes.node.isRequired
};

export default DaLatSwiper;
