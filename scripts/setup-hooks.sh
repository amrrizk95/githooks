#!/usr/bin/env bash
cp scripts/hooks/* .git/hooks/
chmod +x .git/hooks/*
echo "Hooks have been installed!"